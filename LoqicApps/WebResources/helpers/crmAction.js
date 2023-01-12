/** @format */

/**
 *Retrieves data from CRM. Mimic REST api for CRM portal.
 * @param {string} query - Query name. Name of action which will be executed in CRM plugin. Required argument.
 * @param {Object} [params] Object of values required for action execution in CRM.
 * @param {string} [loader] DOM-selector which will be shown while request time.
 * @returns {Promise<string>} JSON response from CRM.
 */
import { b64EncodeUnicode } from './b64EncodeUnicode';

/* eslint-disable no-console */
export function crmAction(query, params, loader) {
    if (!query) throw new Error('Invalid query parameter');

    loader = document.querySelector(loader);
    showLoader(loader, true);

    params = params ? b64EncodeUnicode(JSON.stringify(params)) : '';
    const cache = new Date().getTime();
    const url = `${window.location.origin}/entityquery/?query=${query}&parameters=${params}&cacheString=${cache}`;

    return new Promise(function (resolve, reject) {
        const xhr = new XMLHttpRequest();
        xhr.open('GET', url, true);
        xhr.addEventListener(
            'load',
            function () {
                try {
                    const result = JSON.parse(this.responseText);
                    showLoader(loader, false);
                    resolve(result);
                } catch (e) {
                    console.log(e);
                    showLoader(loader, false);
                    reject(e);
                }
            },
            false
        );

        xhr.addEventListener(
            'error',
            function () {
                showLoader(loader, false);
                reject(this.statusText);
            },
            false
        );

        xhr.send();
    });
}

function showLoader(loader, flag) {
    if (loader) {
        if (flag) loader.style.display = 'block';
        else loader.style.display = 'none';
    }
}
