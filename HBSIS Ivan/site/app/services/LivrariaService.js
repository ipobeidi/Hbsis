(function () {
    'use strict';
    angular.module('Livraria').service('LivrariaService', ['$http', function ($http) {

        var _incluir = function (prLivro) {
            return $http.post("/Livro/CriarLivros", prLivro);
        }

        var _editar = function (prLivro) {
            return $http.post("/Livro/UpdateLivros", prLivro);
        }

        
        var _excluir = function (prLivro) {
            return $http.post("/Livro/DeletaLivro", prLivro);
        }

        var _carregar = function() {
            return $http.get("/Livro/PegaLivros");
         }

        this.incluir = _incluir;
        this.editar = _editar;
        this.excluir = _excluir;
        this.carregar =_carregar;
    }]);
})();