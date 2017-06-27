/**
 * Created by kento on 6/27/17.
 */

import * as React from 'react';
import { Container, Message } from 'semantic-ui-react';

class PageContainer extends React.Component {
    constructor(props){
        super(props);
    }
    
    render() {
        return(
            <Container fluid>
                <Message warning header='Site under development. Some of these items going to be developed:'
                list={
                    ['Support multiple webpackdev middlewares',
                    'Implement Auth stuff',
                    'Improve JS Development',
                    'Documentation',
                    'etc . . . '
                    ]
                }
                />
                {this.props.children} 
            </Container>
            
        );
    }
}

export default PageContainer;
    