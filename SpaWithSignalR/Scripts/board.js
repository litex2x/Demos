/// <reference path="jquery-1.9.1.min.js" />

var board = new function () {
    function updateBoard(messages) {
        if (messages.length > 0) {
            $('.board').empty();
            $.each(messages, function (i, v) {
                $('.board').append("<p>" + v.Name + ": " + v.Post + "</p>")
            });
        }
    }

    function init() {
        var connection = $.hubConnection();
        var hub = connection.createHubProxy('BoardHub');
        hub.on('updateBoard', updateBoard);
        connection.start();
    }

    $(document).ready(init);
};