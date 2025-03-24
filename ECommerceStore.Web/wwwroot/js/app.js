
var App = {
    Common: {

    },
    Core: {

    },
    Pages: {
        HomePage: {
            init: function () {
                App.Utils.Widgets.createProductSwiper('featured-products-slider');
                App.Utils.Widgets.createProductSwiper('discounted-products-slider');
            }
        }
    },
    Utils: {
        Widgets: {

        }
    }
};