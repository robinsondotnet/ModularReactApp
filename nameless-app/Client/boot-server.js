/**
 * Created by kento on 6/22/17.
 */
import React from 'react';
import ReactDOMServer from 'react-dom/server';
import AppContainer from './containers/AppContainer';

import { createServerRenderer } from 'aspnet-prerendering';

import { Segment, Sidebar, Grid } from 'semantic-ui-react';
import MenuContainer from "./containers/MenuContainer";
import MenuExampleStackable from "./containers/MenuExampleStackable"; 

export default createServerRenderer(params => {
 return new Promise((resolve, reject) => {
     const html = ReactDOMServer.renderToString(
             <AppContainer> 
                    <MenuContainer/>
       <Sidebar.Pusher>
                 <MenuExampleStackable/>
     <Grid>
     <Grid.Row>
     <Grid.Column width={2} >
     </Grid.Column>
     <Grid.Column width={14} >
        <Segment basic>
            <div dangerouslySetInnerHTML={{__html: params.data.body}} >
            </div>
        </Segment>
     </Grid.Column>
     </Grid.Row>
     </Grid>
       </Sidebar.Pusher>
            </AppContainer>
     );
  resolve({ html });
 });
});

