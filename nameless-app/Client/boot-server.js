/**
 * Created by kento on 6/22/17.
 */
import React from 'react';
import ReactDOMServer from 'react-dom/server';
import AppContainer from './containers/AppContainer';

import { createServerRenderer } from 'aspnet-prerendering';

import { Segment, Sidebar } from 'semantic-ui-react';
import MenuContainer from "./containers/MenuContainer"; 

export default createServerRenderer(params => {
 return new Promise((resolve, reject) => {
     const html = ReactDOMServer.renderToString(
             <AppContainer> 
                    <MenuContainer/>
       <Sidebar.Pusher>
        <Segment basic>
            <div dangerouslySetInnerHTML={{__html: params.data.body}} >
            </div>
        </Segment>
       </Sidebar.Pusher>
            </AppContainer>
     );
  resolve({ html });
 });
});

