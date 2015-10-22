$(document).ready(function () {
    var number = '';
    var number2 = '';
    var operation;
    var Result;

    $("#txtResult").val("0");
    $(".input").click(function () {
        if ($("#txtResult").val() == "0") {

            $("#txtResult").val($(this).val());
        }
        else {
            number += $(this).val();

            $("#txtResult").val(number);
        }

    });
    $(".performance").click(function () {
        number2 = $("#txtResult").val();
        $("#txtstatus").val(number2);
        $("#txtResult").val("0");
        operation = $(this).val();
    });


    $(".clear").click(function () {

        $("#txtResult").val("0");
        $("#txtstatus").val("");
        Result = "";
        number = "";
        number2 = "";

    });


    $("#calculate").click(function () {
        switch (operation) {
            case "+":
                Result = parseFloat((number2)) + parseFloat($("#txtResult").val());
                $("#txtstatus").val(number2 + "+" + $("#txtResult").val());
                $("#txtResult").val(Result);
                break;
            case "-":
                Result = parseFloat((number2)) - parseFloat($("#txtResult").val());
                $("#txtstatus").val(number2 + "-" + $("#txtResult").val()); $("#txtResult").val(Result);
                break;
            case "*":
                Result = parseFloat((number2)) * parseFloat($("#txtResult").val());
                $("#txtstatus").val(number2 + "*" + $("#txtResult").val());
                $("#txtResult").val(Result);
                break;
            case "/":
                Result = parseFloat((number2)) / parseFloat($("#txtResult").val());
                $("#txtstatus").val(number2 + "/" + $("#txtResult").val());
                $("#txtResult").val(Result);
                break;
            case "%":
                Result = parseFloat((number2)) % parseFloat($("#txtResult").val());
                $("#txtstatus").val(number2 + "%" + $("#txtResult").val());
                $("#txtResult").val(Result);
                break;
        }

    });



});