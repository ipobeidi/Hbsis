(function () {
    'use strict';
    angular.module('Livraria').controller('LivrariaController', ['$scope', 'LivrariaService', function ($scope, LivrariaService) {

        var vm = this;
        vm.Livro = {};
        vm.acoLivros = [];
        vm.salvar = salvar;
        vm.editar = editar;
        vm.excluir = excluir;
        vm.init = init;
        vm.hasEditar = false;

        function init() {
            LivrariaService.carregar().then(function (response) {
                vm.acoLivros = response.data;
            });
        }
        function salvar(isFormValid) {
            if (isFormValid && !vm.hasEditar) {
                LivrariaService.incluir(vm.Livro).then(function (response) {
                    init();
                    vm.Livro = {};
                });
            }
            if (isFormValid && vm.hasEditar) {
                LivrariaService.editar(vm.Livro).then(function (response) {
                    let lObject = vm.acoLivros.filter(t => t.Id === vm.Livro.Id);

                    angular.forEach(vm.acoLivros, function (value, key) {
                        if (value.Id == lObject[0].Id) {
                            value.Nome = vm.Livro.Nome;
                            value.Autor = vm.Livro.Autor;
                            value.Ano = vm.Livro.Ano;
                        }
                    });
                    vm.Livro = {};
                    vm.hasEditar = false;
                });
            }
            if (!isFormValid)
                alert("Preencha todos os campos!");
        }

        function editar(prLivro) {
            vm.hasEditar = true;

            vm.Livro.Id = prLivro.Id;
            vm.Livro.Nome = prLivro.Nome;
            vm.Livro.Autor = prLivro.Autor;
            vm.Livro.Ano = prLivro.Ano;
        }

        function excluir(prLivro) {
            LivrariaService.excluir(prLivro).then(function (response) {
               init();
            });
        }
    }]);
})();