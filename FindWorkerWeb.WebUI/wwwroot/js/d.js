var opts = {
  lines: 13, // The number of lines to draw
  length: 10, // The length of each line
  width: 2, // The line thickness
  radius: 10, // The radius of the inner circle
  corners: 1, // Corner roundness (0..1)
  rotate: 0, // The rotation offset
  direction: 1, // 1: clockwise, -1: counterclockwise
  color: '#000', // #rgb or #rrggbb or array of colors
  speed: 1, // Rounds per second
  trail: 60, // Afterglow percentage
  shadow: false, // Whether to render a shadow
  hwaccel: false, // Whether to use hardware acceleration
  className: 'spinner', // The CSS class to assign to the spinner
  zIndex: 2e9, // The z-index (defaults to 2000000000)
  top: '50%', // Top position relative to parent
  left: '50%' // Left position relative to parent
};

$(document).ready(function(){
  var csrf = $('meta[name="csrf-token"]').attr('content');

  $('[data-tooltip="tooltip"]').tooltip();

  $(".job_512_link").click(function(){
    window.location = $(this).find("h1 a").attr("href");
    return false;
  });

  $(".job_location a").click(function(){
    window.location = $(this).attr("href");
    return false;
  });


  $(".follow_btn").click(function(){
    var $this = $(this);
    var ac = $(this).attr("data-active");
    var id = $(this).attr("data-id").replace(/"/gi, '');

    $.post('/api/follow?_csrf=' + csrf, "id=" + id, function(data) {
        if (data.error) {
          alert("Birşey ters gitti");
        } else {
          if (ac == "0") {
            $this.text(i18n_array["non-0"][0]["follow_active_btn"]);
            $this.removeClass("btn-gray").addClass("btn-success");
            $this.attr("data-active", "1");
          } else {
            $this.text(i18n_array["non-0"][0]["follow_btn"]);
            $this.removeClass("btn-success").addClass("btn-gray");
            $this.attr("data-active", "0");
          }

          var $closest_content = $this.closest(".following_list");
          if ($closest_content.length == 1) {
            var count = parseInt($closest_content.find(".profile_follow_count .count").text());
            if (ac == "0") count++;
            else count--;

            $closest_content.find(".profile_follow_count .count").text(count);
          }

          var $following = $this.closest(".job_512_box");
          if ($following.length == 1) {
            var content = $following.find(".profile_follow_count .count");
            var count = parseInt(content.text());

            if (ac == "0") count++;
            else count--;

            content.text(count);
          }

          if ($(".badge_follow_count").length == 1) {
            if (ac == 0) $(".badge_follow_count").text(parseInt($(".badge_follow_count").text()) + 1);
            else 
              $(".badge_follow_count").text(parseInt($(".badge_follow_count").text()) - 1);
          }
        }
      });
  });

  $(".like_button").not('.like_button_disable').click(function(){
    var $this = $(this);
    var ac = $(this).attr("data-active");
    var id = $(this).attr("data-id").replace(/"/gi, '');
    var count_div = $(this).closest(".pull-left").find(".count_likes .count");
    var count = parseInt(count_div.text());

    $.post('/api/like?_csrf=' + csrf, "id=" + id, function(data) {
        if (data.error) {
          alert("Birşey ters gitti");
        } else {
          if (ac == "0") {
            $this.attr("data-active", "1").addClass("like_active");
            count++;
          } else {
            $this.attr("data-active", "0").removeClass("like_active");
            count--;
          }
          count_div.text(count);
          if ($(".badge_like_count").length == 1) {
            if (ac == 0) $(".badge_like_count").text(parseInt($(".badge_like_count").text()) + 1);
            else 
              $(".badge_like_count").text(parseInt($(".badge_like_count").text()) - 1);
          }
        }
      });
  });

  var modal_like, button_like, modal_share, button_share;

  $('#likesModal').on('show.bs.modal', function (event) {
    button_like = $(event.relatedTarget);
    var id = button_like.attr("data-id").replace(/"/gi, '');
    modal_like = $(this);

    $.post('/api/like_list?_csrf=' + csrf, "id=" + id, function(data) {
      modal_like.find(".likesModalLoading").hide();
      modal_like.find(".likesModalContent").html(data);
      modal_like.find(".likesModalContent").show();
    });
  });

  $('#likesModal').on('hidden.bs.modal', function (event) {
    button_like = $(event.relatedTarget) // Button that triggered
    modal_like = $(this)
    modal_like.find(".likesModalLoading").show();
    modal_like.find(".likesModalContent").html("");
    modal_like.find(".likesModalContent").hide();
  });

  $('#applyModal').on('show.bs.modal', function (event) {
    button_like = $(event.relatedTarget);
    var id = button_like.attr("data-id").replace(/"/gi, '');
    modal_like = $(this);

    $.post('/api/apply_list?_csrf=' + csrf, "id=" + id, function(data) {
      modal_like.find(".likesModalLoading").hide();
      modal_like.find(".likesModalContent").html(data);
      modal_like.find(".likesModalContent").show();
    });
  });

  $('#applyModal').on('hidden.bs.modal', function (event) {
    button_like = $(event.relatedTarget) // Button that triggered
    modal_like = $(this)
    modal_like.find(".likesModalLoading").show();
    modal_like.find(".likesModalContent").html("");
    modal_like.find(".likesModalContent").hide();
  });

  var modal_complaint, button_complaint;

  $('#jobComplaint').on('show.bs.modal', function (event) {
    button_complaint = $(event.relatedTarget);
    var id = button_complaint.attr("data-id").replace(/"/gi, '');
    modal_complaint = $(this);
    
    $.get('/api/complaint?id=' + id, function(data) {
      modal_complaint.find(".modal_loading").hide();
      modal_complaint.find(".modal_content").html(data);
      modal_complaint.find(".modal_content").show();
      adjustModalMaxHeightAndPosition();
    });
  });

  $("#jobComplaint").on('submit', '.complaint_form form', function(e){
    e.preventDefault();
    var form = $(this);
    var btn = $(this).find("button");
    btn.button('loading');

    var complaint = $("input[name='complaint']:checked").val();
    if (typeof complaint != "undefined") {
      $.post('/api/complaint', form.serialize(), function(data) {
        btn.button('reset');
        if (data.success) {
          $(".complaint_form").slideUp(300);
          $(".complaint_form_success").fadeIn(200);
        } else {
          alert('Bir sorun oldu.')
        }
      });
    }     
  });

  $('#jobComplaint').on('hidden.bs.modal', function (event) {
    button_complaint = $(event.relatedTarget) // Button that triggered
    modal_complaint = $(this);
    modal_complaint.find(".modal_loading").show();
    modal_complaint.find(".modal_content").html("");
    modal_complaint.find(".modal_content").hide();
  });

  var shareLink = "";
  var shareTitle = "";
  $('#jobShareModal').on('show.bs.modal', function (event) {
    button_share = $(event.relatedTarget);
    modal_share = $(this);

    shareLink = button_share.attr('data-href');
    shareTitle = encodeURIComponent(button_share.attr('data-title'));
  });

  $('.jobShareTweet').click(function(e){
    e.preventDefault();

    var loc = shareLink;
   
    //We get the title of the link
    var title  = shareTitle;
   
    //We trigger a new window with the Twitter dialog, in the middle of the page
    window.open('http://twitter.com/share?url=' + loc + '&text=' + title + '&', 'twitterwindow', 'height=450, width=550, top='+($(window).height()/2 - 225) +', left='+$(window).width()/2 +', toolbar=0, location=0, menubar=0, directories=0, scrollbars=0');
   
  });

  $('.jobShareFacebook').click(function(e){
    e.preventDefault();

    var loc = shareLink;

    window.open('https://www.facebook.com/sharer/sharer.php?u=' + loc, 'facebookwindow', 'height=450, width=550, top='+($(window).height()/2 - 225) +', left='+$(window).width()/2 +', toolbar=0, location=0, menubar=0, directories=0, scrollbars=0');
  });

  $('.jobSharePlus').click(function(e){
    e.preventDefault();

    var loc = shareLink;

    window.open('https://plus.google.com/share?url=' + loc, 'pluswindow', 'height=450, width=550, top='+($(window).height()/2 - 225) +', left='+$(window).width()/2 +', toolbar=0, location=0, menubar=0, directories=0, scrollbars=0');
  });
});

function adjustModalMaxHeightAndPosition(){
  $('.modal').each(function(){
    if($(this).hasClass('in') === false){
      $(this).show();
    }
    var contentHeight = $(window).height() - 60;
    var headerHeight = $(this).find('.modal-header').outerHeight() || 2;
    var footerHeight = $(this).find('.modal-footer').outerHeight() || 2;

    $(this).find('.modal-content').css({
      'max-height': function () {
        return contentHeight;
      }
    });

    $(this).find('.modal-body').css({
      'max-height': function () {
        return contentHeight - (headerHeight + footerHeight);
      }
    });

    $(this).find('.modal-dialog').addClass('modal-dialog-center').css({
      'margin-top': function () {
        return -($(this).outerHeight() / 2);
      },
      'margin-left': function () {
        return -($(this).outerWidth() / 2);
      }
    });
    if($(this).hasClass('in') === false){
      $(this).hide();
    }
  });
}
if ($(window).height() >= 320){
  $(window).resize(adjustModalMaxHeightAndPosition).trigger("resize");
}