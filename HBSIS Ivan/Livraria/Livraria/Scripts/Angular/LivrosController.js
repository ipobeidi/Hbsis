var app = angular.module('Livraria', []);


app.controller('LivrosController', ['$scope', '$http', LivrosController]);

function LivrosController($scope, $http)
{
    $http.get('http://localhost:16523/api/livros').success(function (data) {
        $scope.listaLivros = data;
    }).error(function () {
        $scope.error = "erro";
    })
}