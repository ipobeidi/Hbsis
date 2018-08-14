angular.module('Livraria').factory('UrlInteceptor', ['$q', '$injector', function ($q, $injector) {
    return {
        request: function (config) {
            //Adicionar a URL da API antes da requisição
            if(!config.url.includes('.html'))
            {
                let URL_API = $injector.get('URL_API');
                config.url = URL_API + config.url;
            }

            return config;
        },
        requestError: function (rejection) {
            return $q.reject(rejection);
        },
        response: function (response) {
            return response;
        },
        responseError: function (rejection) {
            return $q.reject(rejection);
        }
    };
}]);