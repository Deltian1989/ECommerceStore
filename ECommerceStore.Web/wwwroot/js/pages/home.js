App.Pages.HomePage = {
    initSlider: function (id) {
        App.Utils.Widgets.createProductSwiper(id);
    },
    initSpecialOffersSlider: function () {
        App.Utils.Widgets.createSpecialOffersSlider();
    }
}