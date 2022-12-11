app.controller('CategoryCtrl', function ($scope, $http) {
    $scope.ShowPopup = true;
    $scope.SaveChange = function () {
        AddCategory();
    }

    function GetAllCategory() {
        $http({
            method: 'GET',
            url: ServiceUrl + `/api/Category/GetAllCategory`,
            //headers: {
            //    'Authorization': `bearer ${$scope.Token}`,
            //    'Accept': 'application/json',
            //    'Content-Type': 'application/json'
            //}
        }).then(function (response) {
            $scope.CategoryList = response.data.ResponseModel;
        }).catch(function (error) {
            alert(error);
        });
    }
    GetAllCategory();

    function AddCategory() {
        $http({
            method: 'GET',
            url: ServiceUrl + `/api/Category/AddCategory/${$scope.CategoryModel.Name}/${$scope.CategoryModel.Icon}/${$scope.CategoryModel.Description}/${$scope.CategoryModel.ParentId}`,
        }).then(function (response) {
            alert("Kayıt Başarılı");
            GetAllCategory();
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
