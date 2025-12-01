using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Hosting;

namespace OnePageWebVer3 {
    public class IndexModel : PageModel {
        private readonly IWebHostEnvironment _env;

        public IndexModel(IWebHostEnvironment env) {
            _env = env;
        }

        public List<string> ContemporaryImages { get; set; } = new();
        public List<string> ModernImages { get; set; } = new();
        public List<string> FashionImages { get; set; } = new();

        public void OnGet() {
            ContemporaryImages = GetImagesFrom("images/Contemporary");
            ModernImages = GetImagesFrom("images/Modern");
            FashionImages = GetImagesFrom("images/Fashion");
        }

        private List<string> GetImagesFrom(string folder) {
            var fullPath = Path.Combine(_env.WebRootPath, folder);

            if (!Directory.Exists(fullPath))
                return new List<string>();

            return Directory
                .GetFiles(fullPath)
                .Select(file => "/" + folder + "/" + Path.GetFileName(file))
                .ToList();
        }
    }
}