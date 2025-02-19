document.addEventListener("DOMContentLoaded", function () {
    let carousel = document.querySelector("#featuredProductsCarousel");
    let carouselInstance = new bootstrap.Carousel(carousel, {
        interval: 5000,
        wrap: true
    });

    carousel.addEventListener("slide.bs.carousel", function (e) {
        let itemsPerSlide = 8;
        let totalItems = document.querySelectorAll("#featuredProductsCarousel .carousel-item").length;

        if (e.direction === "left") {
            let nextItem = e.relatedTarget;
            let index = [...nextItem.parentElement.children].indexOf(nextItem);

            if (index + itemsPerSlide > totalItems) {
                for (let i = 0; i < itemsPerSlide - (totalItems - index); i++) {
                    let firstItem = nextItem.parentElement.children[i];
                    nextItem.parentElement.append(firstItem);
                }
            }
        }
    });
});