/**
 * Created by kento on 6/26/17.
 */

import * as React from 'react';
import { Segment, Sidebar } from 'semantic-ui-react';

class AppContainer extends React.Component {
    constructor(props){
        super(props)
    }
    
    render(){
        return(
            <Sidebar.Pushable as={Segment}>
                {this.props.children}
            </Sidebar.Pushable>
        );
    }
}
    
export default AppContainer;