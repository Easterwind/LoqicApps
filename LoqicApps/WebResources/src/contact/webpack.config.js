// eslint-disable-next-line no-undef
const path = require('path');

// eslint-disable-next-line no-undef
module.exports = {
    entry: {
        'contact.inline': './src/contact.inline.js'
    },
    output: {
        filename: '[name].inline.js',
        path: path.resolve('dist', 'dev')
    },
    module: {
        rules: [
            {
                test: /\.m?js$/,
                exclude: /(node_modules|bower_components)/,
                use: {
                    loader: 'babel-loader',
                    options: {
                        presets: ['@babel/preset-env']
                    }
                }
            }
        ]
    },
    optimization: {
        minimize: false
    },
    mode: 'production'
};
