$(document).ready(function () {
    $(".row").find("button").click(function () {
        var jsonData = $(this).data("key");
        var item = { name: jsonData.name, productId: jsonData.productId, price: jsonData.price, qty: 1 };
        $.post("/Cart/AddItem", item, function () {
            alert("Item Successfully Added to Cart !!");
        });
    });

    $("#searchProduct").change(function () {
        if ($(this).val().length < 3) {
            $("#categoryData").show();
            $("#productData").hide();
            return false;
        }
        $.getJSON("/Home/SearchProducts", { productname: $(this).val() }, function (data) {
            console.log(data);
            var htmlString = "";
            for (let i = 0; i < data.length; i++) {
                htmlString += "<div class='col-md-4'><h2>" + data[i].name + "</h2><p><a href='/Product/Detail/" + data[i].productId +"'><img src='../Content" + data[i].path + "'" + " height='200' width='200' /></a></p> "
                    + "<p>" + data[i].price + "</p><p>" + data[i].description + "</p><p><button class='btn btn-primary btn-lg'>Add To Cart</button></p></div>";
            }
            $("#productData").show();
            $("#productData").html(htmlString);
            $("#categoryData").hide();
        });
    });

    $('#checkoutForm').card({
        container: '.card-wrapper',
        width: 280,

        formSelectors: {
            nameInput: 'input[name="first-name"], input[name="last-name"]'
        }
    });

    $("#cancelData").click(function (e) {
        e.preventDefault(); // prevents default
        location.href = "/Cart/CartDetail";
        return false;
    });

    
});