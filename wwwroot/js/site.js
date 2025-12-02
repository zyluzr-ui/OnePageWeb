// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

document.addEventListener("DOMContentLoaded", () => {
    const items = document.querySelectorAll("#ContemporaryCarousel .carousel-item");

    items.forEach((item, index) => {
        const total = items.length;

        const leftIndex = (index - 1 + total) % total;
        const rightIndex = (index + 1) % total;

        const leftSrc = items[leftIndex].querySelector(".peek-center").src;
        const rightSrc = items[rightIndex].querySelector(".peek-center").src;

        item.querySelector(".peek-left").src = leftSrc;
        item.querySelector(".peek-right").src = rightSrc;
    });
});
