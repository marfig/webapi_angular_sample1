var mainCtrl = function ($scope, $http) {

    var obtenerPaises = function () {
        $http({ method: 'GET', url: '/api/values' })
            .success(function (data) {
                $scope.paises = data;
            })
            .error(function (data) {
                $scope.error = data.Message;
            });
    };

    obtenerPaises();
}