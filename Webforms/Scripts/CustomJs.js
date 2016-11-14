$("#productListButton").click(function(){

    $.ajax({
        url: "/ProductDetails.aspx",
        data: {
            productID:"<%#:Item.productId%>"
        }
    });
});