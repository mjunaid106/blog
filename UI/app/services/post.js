(function () {
    'use strict';

    blogServices
        .service('PostService', PostService);

    PostService.$inject = ['$http'];

    function PostService($http) {
        this.Posts = getAllPosts;

        function getAllPosts() {
            var promise = $http.get('http://localhost:81/api/Blog/GetAllPosts');
            return promise;
        }
    }
})();