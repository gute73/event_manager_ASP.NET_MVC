$(document).ready(function () {
    var today = new Date();
    $('#textDate').attr('autocomplete', 'off');
    $('#textDate').datepicker({
        showOn: 'focus',
        minDate: today
    });
});