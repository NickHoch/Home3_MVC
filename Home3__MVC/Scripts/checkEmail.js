﻿$(function () {

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
            complete: function (isExists)
            {
                alert(Boolean(isExists));
                if (isExists) {
                    $('#msg').val("Please enter another email");
                    alert("Please enter another email");
                }
            }
        });     
    }
});