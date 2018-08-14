angular.module('Livraria').factory('MessageListInteceptor', ['$q', '$injector', function ($q, $injector) {
    return {
        request: function (config) {
            return config;
        },
        requestError: function (rejection) {
            return $q.reject(rejection);
        },
        response: function (response) {
            if (response.data && response.data instanceof Array && response.data.length > 0 && response.data[0].hasOwnProperty("aMensagem")) {
                for (var i = 0; i < response.data.length; i++) {
                    if (response.data[i].aTipo == 0)
                        alert(response.data[i].aMensagem);
                    else if (response.data[i].aTipo == 1)
                        alert(response.data[i].aMensagem);
                    else if (response.data[i].aTipo >= 2)
                        alert(response.data[i].aMensagem);
                }
                return $q.reject(response); //abortar
            }

            return response;
        },
        responseError: function (rejection) {
            return $q.reject(rejection);
        }
    };
}]);