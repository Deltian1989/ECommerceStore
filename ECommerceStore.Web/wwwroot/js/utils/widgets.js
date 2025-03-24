
App.Utils.Widgets.productSwipers = {};

App.Utils.Widgets.createProductSwiper = function (productSwiperId) {

    if (this.productSwipers[productSwiperId] === undefined) {
        this.productSwipers[productSwiperId] = new Swiper('.' + productSwiperId, {
            slidesPerView: 9,
            freeMode: true,
            spaceBetween: 10,
            navigation: {
                nextEl: '.swiper-button-next',
                prevEl: '.swiper-button-prev'
            },
        });
    }
}