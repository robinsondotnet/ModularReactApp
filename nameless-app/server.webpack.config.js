/** * Created by kento on 6/23/17. */
var path = require('path');

module.exports = {
 entry: { 'main-server': './Client/boot-server.js' },
 resolve: { extensions: [  '.js'  ] },
 output: {
  path: path.join(__dirname, './Client/dist'),
  filename: '[name].js',
  libraryTarget: 'commonjs'
 },
 module: {
  loaders: [
   { test: /\.jsx?$/, loader: 'babel-loader' }
  ]
 },
 target: 'node',
 devtool: 'inline-source-map'
};
    