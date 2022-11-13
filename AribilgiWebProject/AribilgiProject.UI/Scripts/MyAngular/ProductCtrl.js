app.controller('ProductCtrl', function ($scope, $http) {

    $scope.AddToCard = function (Product) {
        var findedItem = $scope.ShoppingCart.find(x => x.Product.ID == Product.ID);
        if (findedItem == null) {
            $scope.ShoppingCart.push({
                Product: Product,
                Quantity: 1
            });
        }
        else {
            findedItem.Quantity++;
        }
        localStorage.setItem("Cart", JSON.stringify($scope.ShoppingCart));

    }
});