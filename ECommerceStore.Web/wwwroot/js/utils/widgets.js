
App.Utils.Widgets.createProductSwiper = function (productSwiperId) {

    if (this.productSwiper) {
        this.productSwiper.destroy(true, true); // Destroy existing instance before reinitializing
    }

    this.productSwiper = new Swiper('.' + productSwiperId, {
        slidesPerView: 7,
        freeMode: true,
        spaceBetween: 10,
        navigation: {
            nextEl: '.swiper-button-next',
            prevEl: '.swiper-button-prev'
        },
    });
}