/** @format */
import { b64EncodeUnicode } from './b64EncodeUnicode.js';

/**
 *Retrieves data from CRM. Mimic REST api for CRM portal.
 * @param {string} query - Query name. Name of action which will be executed in CRM plugin.
 * @param {Object} [params] Object of values required for action execution in CRM.
 * @param {string} [loader] DOM-selector which will be shown while request time.
 * @returns {Promise<string>} JSON response from CRM plugin.
 */
export function crmAction(query, params, loader) {
    if (!query) throw new Error('Invalid query parameter');

    loader = $(loader);
    showLoader(loader, true);

    params = params ? b64EncodeUnicode(JSON.stringify(params)) : '';
    const cache = new Date().getTime();
    const url = `${window.location.origin}/entityquery/?query=${query}&parameters=${params}&cacheString=${cache}`;

    return new Promise(function (resolve, reject) {
        $.ajax({
            url: url,
            method: 'GET',
            async: true
        })
            .done(function (response) {
                resolve(response);
                showLoader(loader, false);
            })
            .fail(function (jqXHR, textStatus) {
                reject(textStatus);
                console.log('Get data for grid has error - ', textStatus);
                showLoader(loader, false);
            });
    });
}

function showLoader(loader, flag) {
    if (flag) loader.show();
    else loader.hide();
}
