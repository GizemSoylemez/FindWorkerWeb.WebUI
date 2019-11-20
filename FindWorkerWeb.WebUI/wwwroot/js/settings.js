$(document).ready(function() {
  var csrf = $("input[name='_csrf']").val();

  var fields2 = {
      usernamet: {
            verbose: false,
            validators: {
                notEmpty: {
                    message: i18n_array["i18n_form_errors"][0]["required"]
                },
                regexp: {
                    regexp: /^[a-zA-Z0-9\.]+$/,
                    message: i18n_array["settings_lists"][0]["2"]
                },
                stringLength: {
                    min: 5,
                    max: 30,
                    message: i18n_array["i18n_form_errors"][0]["username_min_max"]
                },
                remote: {
                    url: '/api/check/username?_csrf=' + csrf,
                    type: 'POST',
                    message: i18n_array["i18n_form_errors"][0]["username_use_error"],
                    delay: 500 
                }
            }
        }
  };

  var fields3 = {
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
        }
  };

  var fields = {
      password: {
          validators: {
              notEmpty: {
                  message: i18n_array["i18n_form_errors"][0]["required"]
              }
          }
      },
      new_password: {
          validators: {
              notEmpty: {
                  message: i18n_array["i18n_form_errors"][0]["required"]
              },
              stringLength: {
                  min: 6,
                  message: ' '
              }
          }
      },
      new_password2: {
          validators: {
              notEmpty: {
                  message: i18n_array["i18n_form_errors"][0]["required"]
              },
              identical: {
                  field: 'new_password',
                  message: i18n_array["i18n_form_errors"][0]["password_not_match"]
              }
          }
      }
  };

  $("#usernameForm").find("form").formValidation({
    framework: 'bootstrap',
    icon: {
        valid: 'glyphicon glyphicon-ok',
        invalid: 'glyphicon glyphicon-remove',
        validating: 'glyphicon glyphicon-refresh glyphicon-refresh-animate'
    },
    fields: fields2
  }).on('success.form.fv', function(e) {
      e.preventDefault();
      var $form = $(e.target);
    
      var bv = $form.data('formValidation');
      bv.resetForm();

      var this_button = $form.find(".btn-primary");
      this_button.button('loading');

      var form_data = $form.serialize();
      $form.find("input, textarea, select, button").prop('disabled', true);

      $.post( '/api/username', form_data, function( data ) {
        $form.find("input, textarea, select, button").prop('disabled', false);
        this_button.button('reset');
        if (data.success) {
          $(".warning_area_content").html('<div class="alert alert-success">' + data.success + '</div>').hide().fadeIn(300);
          $(".form_content, .content_footer_button").slideUp(300);
        } else if (data.error) {
          $(".warning_area_content").html('<div class="alert alert-warning">' + data.error + '</div>').hide().fadeIn(300);
        }
      });
  });

  $("#changePassword").find("form").formValidation({
    framework: 'bootstrap',
    icon: {
        valid: 'glyphicon glyphicon-ok',
        invalid: 'glyphicon glyphicon-remove',
        validating: 'glyphicon glyphicon-refresh'
    },
    fields: fields
  }).on('success.form.fv', function(e) {
      e.preventDefault();
      var $form = $(e.target);
    
      var bv = $form.data('formValidation');
      bv.resetForm();

      var this_button = $form.find(".btn-primary");
      this_button.button('loading');

      var form_data = $form.serialize();
      $form.find("input, textarea, select, button").prop('disabled', true);

      $.post( '/api/changePassword', form_data, function( data ) {
        $form.find("input, textarea, select, button").prop('disabled', false);
        this_button.button('reset');
        if (data.success) {
          $(".warning_area_content").html('<div class="alert alert-success">' + data.success + '</div>').hide().fadeIn(300);
          $(".form_content, .content_footer_button").slideUp(300);
        } else if (data.error) {
          $(".warning_area_content").html('<div class="alert alert-warning">' + data.error + '</div>').hide().fadeIn(300);
        }
      });
  });

  var email_text = "";
  $("#changeEmail").find("form").formValidation({
    framework: 'bootstrap',
    icon: {
        valid: 'glyphicon glyphicon-ok',
        invalid: 'glyphicon glyphicon-remove',
        validating: 'glyphicon glyphicon-refresh glyphicon-refresh-animate'
    },
    fields: fields3
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
    }).on('success.form.fv', function(e) {
      e.preventDefault();
      var $form = $(e.target);
    
      var bv = $form.data('formValidation');
      bv.resetForm();

      var form_data = $form.serialize();
      email_text = $("input[name='email']").val();
      $(".email_text").text('"'+email_text+'"');
      $('#email-change-modal').modal('show');
      
      /*$form.find("input, textarea, select, button").prop('disabled', true);

      */
  });

  $("#confirm-button").click(function(){
    var this_button = $(this);
    this_button.button('loading');
    $('#email-change-modal').modal('hide');
    $.post( '/api/changeEmail?_csrf=' + csrf, "email=" + email_text, function( data ) {
      this_button.button('reset');
      if (data.success) {
        $(".warning_area_content").html('<div class="alert alert-success">' + data.success + '</div>').hide().fadeIn(300);
        $(".form_content, .content_footer_button").slideUp(300);
      } else if (data.error) {
        $(".warning_area_content").html('<div class="alert alert-warning">' + data.error + '</div>').hide().fadeIn(300);
      }
    });
  });

  $("#i18n_notification_form").find("form").submit(function(e){
    e.preventDefault();
    
    var $form = $(this);
    //$form.find("input, textarea, select, button").prop('disabled', true);

    var this_button = $form.find(".btn-primary");
    this_button.button('loading');

    var form_data = $form.serialize();

    $.post( '/api/changeNotifications', form_data, function( data ) {
      //$form.find("input, textarea, select, button").prop('disabled', false);
      this_button.button('reset');
      if (data.success) {
        $(".warning_area_content").text(data.success);
      }
    });

    
  });

});