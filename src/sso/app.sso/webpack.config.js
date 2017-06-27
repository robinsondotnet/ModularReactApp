/**
 * Created by kento on 6/22/17.
 */
var path = require('path');

module.exports = {
 resolve: { extensions: [ '.js', '.jsx' ] },
 module: {
  loaders: [
   { test: /\.jsx?$/, loader: 'babel-loader' }
  ]
 },
 entry: {
  main: ['./Client/boot-client.js'],
 },
 output: {
  path: path.join(__dirname, 'wwwroot'),
  filename: '[name].js',
     publicPath: '/assets/'
 }
};
    