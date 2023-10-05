//Carousel for article news w/ button
$(document).ready(function() {
    const buttonsWrapper = document.querySelector(".article-pagination");
    const slides = document.querySelector(".articles");
    
    buttonsWrapper.addEventListener("click", e => {
      if (e.target.nodeName === "BUTTON") {
        Array.from(buttonsWrapper.children).forEach(item =>
          item.classList.remove("current")
        );
        if (e.target.classList.contains("first")) {
          slides.style.transform = "translateX(-0%)";
          e.target.classList.add("current");
        } else if (e.target.classList.contains("second")) {
          slides.style.transform = "translateX(-1330px)";
          e.target.classList.add("current");
        } else if (e.target.classList.contains('third')){
          slides.style.transform = 'translatex(-2660px)';
          e.target.classList.add('current');
        } else if (e.target.classList.contains("fourth")){
          slides.style.transform = 'translateX(-3990px)';
          e.target.classList.add('current');
        } else if (e.target.classList.contains("fifth")){
          slides.style.transform = 'translateX(-5325px)';
          e.target.classList.add('current');
        }
      }
    });
});


$(document).ready(function () {
    $("#subscribeForm").submit(function (e) {
        e.preventDefault(); // Prevent the form from submitting normally

        // AJAX request to submit the form
        $.ajax({
            type: "POST",
            url: "/crito/controllers/contactscontroller/Subscribe",
            data: $(this).serialize(),
            success: function () {
                // Hide the form and show the success message
                $("#subscribeForm").hide();
                $("#successMessage").show();
            },
        });
    });
});