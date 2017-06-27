/**
 * Created by kento on 6/27/17.
 */

import * as React from 'react';
import GridExampleDividedNumber from "../components/GridExampleDividedNumber";

class ProjectsContainer extends React.Component {
    constructor(props) {
        super(props);
    }
    
    render() {
        return(
            <div>
                <GridExampleDividedNumber />
            </div>
        );
    }
}
    
export default ProjectsContainer;