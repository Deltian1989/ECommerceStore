App.Pages.HomePage = {
    init: function () {
        App.Utils.Widgets.createProductSwiper('FeaturedProducts');
        App.Utils.Widgets.createProductSwiper('DiscountedProducts');
    }
}