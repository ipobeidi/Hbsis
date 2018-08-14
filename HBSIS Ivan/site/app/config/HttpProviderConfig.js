angular.module('Livraria').config(['$httpProvider', function($httpProvider) {
    //registrando os Interceptors
    $httpProvider.defaults.headers.post['Content-Type'] = 'application/json';
    
    //Transformar a requisição em Raw Payload, mandar o object pelo body da requisição
    $httpProvider.defaults.transformRequest = function (data) { return angular.toJson(data); };
    //Carregar Interceptores.
    $httpProvider.interceptors.push("UrlInteceptor"); 
    $httpProvider.interceptors.push("MessageListInteceptor"); 
  }]);