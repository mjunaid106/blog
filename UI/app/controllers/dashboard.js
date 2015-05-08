blogControllers.controller('DashboardController', ['$scope', '$location', 'PostService', function ($scope, $location, PostService) {
    init();
    function init() {
        PostService.Posts().then(
            function onSuccess(response) {
                if (response.data === 'null') {
                    $scope.Message = "No blog post exist";
                }
                else {
                    $scope.BlogPosts = response.data;
                }
            }
        );
     }
    }]);