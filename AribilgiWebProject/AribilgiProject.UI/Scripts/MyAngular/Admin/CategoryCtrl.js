app.controller('CategoryCtrl', function ($scope, $http) {
    //$scope.UserModel = {};

    //$scope.Login = function () {
    //    $http.get(ServiceUrl + `/Account/Login/${$scope.UserModel.UserName}/${$scope.UserModel.Password}`)
    //        .then(function (response) {
    //            if (response.data.access_token != null) {
    //                localStorage.setItem("token", response.data.access_token);
    //                window.location.href = "/admin/index";
    //            }
    //            else {
    //                alert("Başarısız");
    //            }
    //        });
    //}

    function GetAllCategory() {
        $http({
            method: 'GET',
            url: ServiceUrl + `/api/Category/GetAllCategory`,
            headers: {
                'Authorization': `bearer ${$scope.Token}`,
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            }
        }).then(function (response) {
            alert(JSON.stringify(response.data))
        }).catch(function (error) {
            alert(error);
        });
    }
    GetAllCategory();
});