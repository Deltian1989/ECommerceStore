
App.Utils.Widgets.createProductSwiper = function (productSwiperId) {

    if (this.productSwiper) {
        this.productSwiper.destroy(true, true); // Destroy existing instance before reinitializing
    }

    this.productSwiper = new Swiper('.' + productSwiperId, {
        slidesPerView: 4, // Number of visible slides
        spaceBetween: 20, // Space between slides
        loop: true, // Enable infinite scrolling
        pagination: {
            el: '.swiper-pagination',
            clickable: true
        },
        navigation: {
            nextEl: '.swiper-button-next',
            prevEl: '.swiper-button-prev'
        },
        breakpoints: {
            320: { slidesPerView: 1 },
            640: { slidesPerView: 2 },
            1024: { slidesPerView: 3 },
            1280: { slidesPerView: 4 }
        }
    });
}