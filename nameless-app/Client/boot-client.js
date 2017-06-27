/**
 * Created by kento on 6/22/17.
 */
import * as React from 'react';
import * as ReactDOM from 'react-dom';
import ProjectsContainer from "./containers/ProjectsContainer";
import PageContainer from "./containers/PageContainer";

ReactDOM.render(
    <PageContainer>
        <ProjectsContainer/>
    </PageContainer>, 
    document.getElementById('my-spa'));
    