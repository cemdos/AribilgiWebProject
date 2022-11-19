app.controller('CartCtrl', function ($scope, $http) {
    $scope.ApplyCoupon = function (CouponCode) {
        $scope.IsShowLoader = true;
        var paramsItem = {
            CouponCode: CouponCode
        }

        $scope.GetSubTotal = function () {
            var subTotal = 0;
            for (var i = 0; i < $scope.ShoppingCart.length; i++) {
                var cartItem = $scope.ShoppingCart[i];
                subTotal += cartItem.Product.UnitPrice * cartItem.Quantity;
            }
            return subTotal;
        }

        $scope.GetDiscount = function () {
            var subTotal = $scope.GetSubTotal();
            var DiscountPercent = 0;
            if ($scope.Coupon != null)
                DiscountPercent = $scope.Coupon.DiscountPercent;
            return subTotal * DiscountPercent / 100;
        }

        $http.get("/Coupon/GetCheckCoupon", { params: paramsItem })
            .then(function (response) {
                if (response.data.IsSuccess) {
                    $scope.Coupon = response.data.ResponseModel;
                }
                else {
                    alert(response.data.ErrorMessage);
                }
                $scope.IsShowLoader = false;
            });
    }
});