
App.Utils.Widgets = {
    productSwipers: {},
    specialOffersSlider: null,
    createProductSwiper: function (productSwiperId) {

        if (this.productSwipers[productSwiperId] === undefined) {
            this.productSwipers[productSwiperId] = new Swiper('#' + productSwiperId, {
                slidesPerView: 9,
                freeMode: true,
                spaceBetween: 10,
                navigation: {
                    nextEl: '.swiper-button-next',
                    prevEl: '.swiper-button-prev'
                },
            });
        }
    },
    createSpecialOffersSlider: function () {
        if (this.specialOffersSlider === null) {
            this.specialOffersSlider = new Swiper('#specialOffersSlider', {
                slidesPerView: 1,
                spaceBetween: 30,
                loop: true,
                pagination: {
                    el: ".swiper-pagination",
                    clickable: true,
                },
                navigation: {
                    nextEl: ".swiper-button-next",
                    prevEl: ".swiper-button-prev",
                },
            });
        }
    }
}