blogServices
    .service('AccountService', ['$http', function ($http) {
        this.Login = getLoginUser;
        this.Register = Register;

        function getLoginUser(username, password) {
            var data = { "username": username, "password": password };
            var promise = $http.get('http://localhost:81/api/Account/Login/?username=' + username + '&password=' + password);
            return promise;
        }

        function Register(username, password) {
            var data = { "username": username, "password": password };
            var promise = $http.post('http://localhost:81/api/Account', JSON.stringify(data), { header: { 'Content-Type': 'application/json' } });
            return promise;
        }
    }]);