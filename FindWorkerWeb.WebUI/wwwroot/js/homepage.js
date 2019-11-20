$(document).ready(function(){
  var csrf = $('meta[name="csrf-token"]').attr('content');

  setInterval(function(){
    $(".cursor_i").fadeOut(250, function(){ $(this).fadeIn(250); })
  }, 1000)

  var cv1username = "meltem.poyraz";
  var cv1count = 0;
  var cv1 = setInterval(function(){
    $(".mycv_username").text(cv1username.slice(0,cv1count));
    if (cv1username.length == cv1count) {
      $(".example_cv").html('<img src="images/meltem_cv.jpg" />').fadeIn(500);
      clearInterval(cv1);
    }
    cv1count++;
  }, 75);
  

  $("#login-form").submit(function(){
    var status_login = 0;

    $("#login-form input[type='text']").each(function(e){
      if($(this).val() == "") {
        status_login = 1;
        $(this).parent().addClass("has-error");
      }
    });

    if (status_login == 1) return false;

  });

  $("#login-form input").blur(function(){
    if ($(this).val() == "") {
      $(this).parent().addClass("has-error");
    } else {
      $(this).parent().removeClass("has-error");
    }
  });

  $('.dropdown-menu, .dropdown-menu label').click(function(e) {
      e.stopPropagation();
  });

  $('input[type=radio][name=accountType]').change(function() {
    var value = $(this).val();
    $("form#company_signup").hide();
    $("form#signup").hide();
    $("form#"+value).show();
    $("form#"+value).find("input")[0].focus();
  });

  var signupFields = {
      name: {
          validators: {
              notEmpty: {
                  message: i18n_array["i18n_form_errors"][0]["required"]
              }
          }, row: '.half_input'
      }, 
      last_name: {
          validators: {
              notEmpty: {
                  message: i18n_array["i18n_form_errors"][0]["required"]
              }
          }, row: '.half_input'
      }, 
      email: {
          verbose: false,
          validators: {
              notEmpty: {
                  message: i18n_array["i18n_form_errors"][0]["required"]
              },
              emailAddress: {
                message: i18n_array["i18n_form_errors"][0]["email_type"]
              },
              regexp: {
                  regexp: '^[^@\\s]+@([^@\\s]+\\.)+[^@\\s]+$',
                  message: i18n_array["i18n_form_errors"][0]["email_type"]
              },
              remote: {
                  url: '/api/check/email?_csrf=' + csrf,
                  type: 'POST',
                  message: i18n_array["i18n_form_errors"][0]["email_use_error"],
                  delay: 500 
              }
          }
      },
      password: {
          validators: {
              notEmpty: {
                  message: i18n_array["i18n_form_errors"][0]["required"]
              },
              stringLength: {
                  min: 6,
                  message: i18n_array["i18n_form_errors"][0]["password_six_cr"]
              },
          }
      }
  };

  var companySignupFields = {
      name: {
          validators: {
              notEmpty: {
                  message: i18n_array["i18n_form_errors"][0]["required"]
              }
          }
      },  
      email: {
          verbose: false,
          validators: {
              notEmpty: {
                  message: i18n_array["i18n_form_errors"][0]["required"]
              },
              emailAddress: {
                message: i18n_array["i18n_form_errors"][0]["email_type"]
              },
              regexp: {
                  regexp: '^[^@\\s]+@([^@\\s]+\\.)+[^@\\s]+$',
                  message: i18n_array["i18n_form_errors"][0]["email_type"]
              },
              remote: {
                  url: '/api/check/email?_csrf=' + csrf,
                  type: 'POST',
                  message: i18n_array["i18n_form_errors"][0]["email_use_error"],
                  delay: 500 
              }

          }
      },
      password: {
          validators: {
              notEmpty: {
                  message: i18n_array["i18n_form_errors"][0]["required"]
              },
              stringLength: {
                  min: 6,
                  message: i18n_array["i18n_form_errors"][0]["password_six_cr"]
              }
          }
      }
  };

  $("#signup").formValidation({
      framework: 'bootstrap',
      icon: {
          valid: 'glyphicon glyphicon-ok-2',
          invalid: 'glyphicon glyphicon-remove-2',
          validating: 'glyphicon glyphicon-refresh glyphicon-refresh-animate'
      },
      fields: signupFields
    }).on('err.validator.fv', function(e, data) {
            if (data.field === 'email') {
                // The email field is not valid
                data.element
                    .data('fv.messages')
                    // Hide all the messages
                    .find('.help-block[data-fv-for="' + data.field + '"]').hide()
                    // Show only message associated with current validator
                    .filter('[data-fv-validator="' + data.validator + '"]').show();
            }
      });

    $("#company_signup").formValidation({
      framework: 'bootstrap',
      icon: {
          valid: 'glyphicon glyphicon-ok-2',
          invalid: 'glyphicon glyphicon-remove-2',
          validating: 'glyphicon glyphicon-refresh glyphicon-refresh-animate'
      },
      fields: companySignupFields
    }).on('err.validator.fv', function(e, data) {
            if (data.field === 'email') {
                // The email field is not valid
                data.element
                    .data('fv.messages')
                    // Hide all the messages
                    .find('.help-block[data-fv-for="' + data.field + '"]').hide()
                    // Show only message associated with current validator
                    .filter('[data-fv-validator="' + data.validator + '"]').show();
            }
      });

});
/*
$(function () {
    $("input")
        .popover({ title: 'Twitter Bootstrap Popover', content: "It's so simple to create a tooltop for my website!" })
        .blur(function () {
            $(this).popover('hide');
        });
});*/