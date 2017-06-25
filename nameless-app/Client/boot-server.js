/**
 * Created by kento on 6/22/17.
 */

import React from 'react';
import ReactDOMServer from 'react-dom/server';
import DumbContainer from './containers/DumbContainer'
    
import { createServerRenderer } from 'aspnet-prerendering';

export default createServerRenderer(params => {
 return new Promise((resolve, reject) => {
     const html = ReactDOMServer.renderToString(<div>ClientReactApp: <DumbContainer/></div>);
  resolve({ html });
 });
});

