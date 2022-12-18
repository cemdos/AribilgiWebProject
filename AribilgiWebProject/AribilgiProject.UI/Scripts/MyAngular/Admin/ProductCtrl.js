app.controller('ProductCtrl', function ($scope, $http) {
    $scope.ShowPopup = true;
    $scope.SaveChange = function () {
        AddProduct();
    }

    function GetAllProduct() {
        $http({
            method: 'GET',
            url: ServiceUrl + `/api/Product/GetAllProduct`,
        }).then(function (response) {
            $scope.ProductList = response.data.ResponseModel;
        }).catch(function (error) {
            alert(error);
        });
    }
    GetAllProduct();

    function GetAllCategory() {
        $http({
            method: 'GET',
            url: ServiceUrl + `/api/Category/GetAllCategory`,
        }).then(function (response) {
            $scope.CategoryList = response.data.ResponseModel;
        }).catch(function (error) {
            alert(error);
        });
    }
    GetAllCategory();

    function AddProduct() {
        $http({
            method: 'GET',
            url: ServiceUrl + `/api/Product/AddProduct/${$scope.ProductModel.Name}/${$scope.ProductModel.Stock}/${$scope.ProductModel.UnitPrice}/${$scope.ProductModel.Discount}/${$scope.ProductModel.Rate}/${$scope.ProductModel.Description}`,
        }).then(function (response) {
            alert("Kayıt Başarılı");
            GetAllProduct();
            $('#newCategoryPopup').modal('hide');
        }).catch(function (error) {
            alert(error);
        });

        //var post = $http({
        //    method: "POST",
        //    url: ServiceUrl + `/api/Category/AddCategory`,
        //    dataType: 'json',
        //    data: $scope.CategoryModel,
        //    headers: { "Content-Type": "application/json" }
        //});

        //post.success(function (data, status) {
        //    $window.alert("Hello: " + data.Name + " .\nCurrent Date and Time: " + data.DateTime);
        //});

        //post.error(function (data, status) {
        //    $window.alert(data.Message);
        //});
    }
});
