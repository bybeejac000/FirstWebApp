//Check if the entered number is correct
function validate() {
    var hrs = $("#hrs").val();
    hrs = parseInt(hrs);


    if (hrs < 1 || hrs > 10 || isNaN(hrs)) {
        $("#hrs").val("");

        alert("Please enter a number between 1 and 10");
        return false;
    }

    else {
        return true;
    }

}



//Do the rate calculation
function calculate(valid) {


    var hrs = $("#hrs").val();
    hrs = parseInt(hrs);

    var rate = $("#rate").val();
    rate = parseInt(rate);

    if (valid) {
        const total = rate * hrs;

        $("#total").val(total);
    }

}
