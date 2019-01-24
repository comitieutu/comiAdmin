// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    $("#city").change(function (e) {
        e.preventDefault();
        $.ajax({
            url: $(location).attr("href") + "?handler=City",
            type: 'GET',
            dataType: 'json',
            data: {
                id: $('#city option:selected').val() 
            },
            success: function (data) {
                $('#district').empty();
                $.each(data, function (i, item) {
                    $('#district').append($('<option>').text(item.Name).attr('value', item.Id));
                });
            }
        })
    });
    $("#district").change(function (e) {
        e.preventDefault();
        $.ajax({
            url: $(location).attr("href") + "?handler=District",
            type: 'GET',
            dataType: 'json',
            data: {
                id: $('#district option:selected').val()
            },
            success: function (data) {
                $('#city').empty();
                $.each(data, function (i, item) {
                    $('#city').append($('<option>').text(item.Name).attr('value', item.Id));
                });
            }
        })
    });
    $("#cityWarehouse").change(function (e) {
        e.preventDefault();
        $.ajax({
            url: $(location).attr("href") + "?handler=City",
            type: 'GET',
            dataType: 'json',
            data: {
                id: $('#cityWarehouse option:selected').val()
            },
            success: function (data) {
                $('#districtWarehouse').empty();
                $.each(data, function (i, item) {
                    $('#districtWarehouse').append($('<option>').text(item.Name).attr('value', item.Id));
                });
            }
        })
    });
    $("#districtWarehouse").change(function (e) {
        e.preventDefault();
        $.ajax({
            url: $(location).attr("href") + "?handler=District",
            type: 'GET',
            dataType: 'json',
            data: {
                id: $('#districtWarehouse option:selected').val()
            },
            success: function (data) {
                $('#cityWarehouse').empty();
                $.each(data, function (i, item) {
                    $('#cityWarehouse').append($('<option>').text(item.Name).attr('value', item.Id));
                });
            }
        })
    });
});
