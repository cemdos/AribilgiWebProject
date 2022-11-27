var app = angular.module('App', ['ui.select','toaster']);
app.controller('BaseCtrl', function ($scope, $http,toaster) {
    $scope.IsShowLoader = false;
    if (localStorage.getItem("Cart") != null) {
        var Cart = JSON.parse(localStorage.getItem("Cart"));
        $scope.ShoppingCart = Cart;
    }
    else {
        $scope.ShoppingCart = [];
    }

    $scope.CartQuantityIncrease = function (cart) {
        cart.Quantity++;
        localStorage.setItem("Cart", JSON.stringify($scope.ShoppingCart));
    }

    $scope.CartQuantityDecrease = function (cart) {
        cart.Quantity--;
        localStorage.setItem("Cart", JSON.stringify($scope.ShoppingCart));
    }

    $scope.GetSubTotal = function () {
        var subTotal = 0;
        for (var i = 0; i < $scope.ShoppingCart.length; i++) {
            var cartItem = $scope.ShoppingCart[i];
            subTotal += cartItem.Product.UnitPrice * cartItem.Quantity;
        }
        return subTotal;
    }

    $scope.RemoveToCard = function (cartItem) {
        $scope.ShoppingCart = $scope.ShoppingCart.filter(x => x.Product.ID != cartItem.Product.ID);
        localStorage.setItem("Cart", JSON.stringify($scope.ShoppingCart));
    }

    $scope.GetAllCategory = function () {
        $scope.IsShowLoader = true;
        $http.get("/Category/GetAllCategory")
            .then(function (response) {
                if (response.data.IsSuccess) {
                    var FullCategoryList = response.data.ResponseModel;
                    $scope.CategoryList = FullCategoryList.filter(_ => _.ParentId == null);
                    for (var i = 0; i < $scope.CategoryList.length; i++) {
                        $scope.CategoryList[i].ChildCategory =
                            FullCategoryList.filter(_ => _.ParentId == $scope.CategoryList[i].ID)
                    }
                }
                else {
                    alert(response.data.ErrorMessage);
                }
                $scope.IsShowLoader = false;
            });
    }

    $scope.GetAllCategory();
});