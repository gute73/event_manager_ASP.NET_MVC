$(document).ready(function () {
    var today = new Date();

    $('#textDate').datepicker({
        showOn: 'focus',
        minDate: today
    });
});