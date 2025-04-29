(function () {
    "use strict";

    let forms = document.querySelectorAll('.php-email-form');

    forms.forEach(function (form) {
        form.addEventListener('submit', function (event) {
            event.preventDefault();

            let thisForm = this;
            let action = thisForm.getAttribute('action') || '/default-action';
            let recaptcha = thisForm.getAttribute('data-recaptcha-site-key');

            let loading = thisForm.querySelector('.loading');
            let errorMessage = thisForm.querySelector('.error-message');
            let sentMessage = thisForm.querySelector('.sent-message');

            if (loading) loading.classList.add('d-block');
            if (errorMessage) errorMessage.classList.remove('d-block');
            if (sentMessage) sentMessage.classList.remove('d-block');

            let formData = new FormData(thisForm);

            if (recaptcha) {
                if (typeof grecaptcha !== 'undefined') {
                    grecaptcha.ready(function () {
                        grecaptcha.execute(recaptcha, { action: 'php_email_form_submit' })
                            .then(token => {
                                formData.set('recaptcha-response', token);
                                php_email_form_submit(thisForm, action, formData);
                            })
                            .catch(error => displayError(thisForm, error));
                    });
                } else {
                    displayError(thisForm, 'reCAPTCHA API not loaded!');
                }
            } else {
                php_email_form_submit(thisForm, action, formData);
            }
        });
    });

    function php_email_form_submit(thisForm, action, formData) {
        fetch(action, {
            method: 'POST',
            body: formData,
            headers: { 'X-Requested-With': 'XMLHttpRequest' }
        })
            .then(response => {
                if (response.ok) {
                    return response.text();
                } else {
                    throw new Error(`${response.status} ${response.statusText} at ${response.url}`);
                }
            })
            .then(data => {
                let loading = thisForm.querySelector('.loading');
                let sentMessage = thisForm.querySelector('.sent-message');

                if (loading) loading.classList.remove('d-block');

                if (data.trim() === 'OK' && sentMessage) {
                    sentMessage.classList.add('d-block');
                    thisForm.reset();
                } else {
                    throw new Error(data || 'No valid response from server.');
                }
            })
            .catch(error => displayError(thisForm, error));
    }

    function displayError(thisForm, error) {
        let loading = thisForm.querySelector('.loading');
        let errorMessage = thisForm.querySelector('.error-message');

        if (loading) loading.classList.remove('d-block');
        if (errorMessage) {
            errorMessage.innerHTML = error.message || error;
            errorMessage.classList.add('d-block');
        }
    }

})();
