$(function () {
    var x = document.getElementById('Email');
    x.addEventListener('blur', myBlurFunction, true);

    function myBlurFunction() {
        let email = $('#Email').val();
        let data = JSON.stringify({
            'email': email
        });
        let url = $(this).data('url');
        $.ajax({
            type: 'POST',
            url: url,
            data: data,
            contentType: 'application/json',
            success: function (isExists) {
                if (isExists === 'True') {
                    $('#msg').text('Please enter another email')
                             .addClass('field-validation-error');
                    $('#Email').addClass('input-validation-error');
                }
                else {
                    $('#msg').text('');
                    $('#Email').removeClass('input-validation-error');
                }
            }
        });    
    }
});