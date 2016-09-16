elements = {};

//Setup DOM elements and Event Listeners
ready(function () {
    elements = {
        cipherText: document.getElementById('CipherText'),
        form: document.getElementById('encryptform'),
        pan: document.getElementById('ccnumber'),
        pubKey: document.getElementById('TxEncryptionKey'),
        expMonth: document.getElementById('expiry_month'),
        expYear: document.getElementById('expiry_year'),
        submitButton: document.getElementById('submitButton')
    };

    util.addEventListener(elements.form, 'submit', submitForm);
});

var util = {
    addEventListener:
		function (el, eventName, handler) {
		    if (el.addEventListener) {
		        el.addEventListener(eventName, handler, false);
		    } else {
		        el.attachEvent('on' + eventName, function () {
		            handler.call(el);
		        });
		    }
		},
    removeEventListener:
    function (el, eventName, handler) {
        if (el.removeEventListener) {
            el.removeEventListener(eventName, handler, false);
        }
        if (el.detachEvent) {
            el.detachEvent('on' + eventName, handler);
        }
    },
    hasClass:
        function (element, cls) {
            return (' ' + element.className + ' ').indexOf(' ' + cls + ' ') > -1;

        },
    preventDefault: function (evt) {
        var ev = evt !== undefined ? evt : window.event;
        if (ev.preventDefault) {

            ev.preventDefault();
        } else {
            ev.returnValue = false;
        }
        return ev;
    },
    addClass:
		function (el, className) {
		    if (el) {
		        if (el.classList) {
		            el.classList.add(className);
		        } else {
		            el.className += ' ' + className;
		        }

		    }
		},
    removeClass:
		function (el, className) {
		    if (el) {
		        if (el.classList) {
		            el.classList.remove(className);
		        } else {
		            el.className = el.className.replace(new RegExp('(^|\\b)' + className.split(' ').join('|') + '(\\b|$)', 'gi'), ' ');
		        }
		    }
		},
    validateExpiration:
        function (el) {
            var expiryMonth = elements.expMonth.options[elements.expMonth.selectedIndex].value - 1;
            var expiryYear = elements.expYear.options[elements.expYear.selectedIndex].value;
            var expiryDate = new Date(expiryYear, expiryMonth);

            //Set currentDate to beginning of current month
            var d = new Date();
            var currentMonth = d.getMonth();
            var currentYear = d.getFullYear();
            var currentDate = new Date(currentYear, currentMonth);

            if (expiryDate < currentDate) {
                util.addClass(elements.expMonth, 'input-validation-error');
                return false;
            } else {
                util.removeClass(elements.expMonth, 'input-validation-error');
                return true;
            }
        }
};
//On form submission, call the encrypt function
function submitForm(e) {
    var pan = elements.pan.value.replace(/[^0-9]/g, '');
    var validDate = util.validateExpiration();

    //ad your own CC validation here
    if (!pan.match(/^[0-9]{15,16}$/)) {
        util.addClass(elements.pan, 'input-validation-error');
        util.preventDefault(e);
        return false;
    //validate future expiration date
    } else if (!validDate) {
        util.preventDefault(e);
        return false;
    }
    else {
        encrypt();
        return true;
    }

}

function encrypt() {

    //encrypt the data and add the ciper text to the form
    elements.cipherText.value = TxEncrypt(elements.pubKey.value, elements.pan.value);
    //remove the clear text pan from the form
    elements.pan.value = "****************";
}

function ready(fn) {
    if (document.addEventListener) {
        document.addEventListener('DOMContentLoaded', fn);
    } else {
        document.attachEvent('onreadystatechange', function () {
            if (document.readyState === 'complete') {
                fn();
            }
        });
    }
}