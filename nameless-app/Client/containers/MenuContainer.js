/**
 * Created by kento on 6/26/17.
 */

import React, { Component } from 'react'
import { Dropdown, Icon, Input, Menu, Sidebar, Segment} from 'semantic-ui-react'

export default class MenuContainer extends Component {
 constructor(props) {
  super(props);  
  this.state = {};
 }


 handleItemClick = (e, { name }) => this.setState({ activeItem: name });

 render() {
  const { activeItem } = this.state;

  return (
  <Sidebar as={Menu} width='thin' icon='labeled' inverted animation='overlay' visible={true} vertical>
   <Menu.Item>
   <Input placeholder='Search...' />
   </Menu.Item>

   <Menu.Item name='projects' active={activeItem === 'projects'} onClick={this.handleItemClick}>
   <Icon name='grid layout' />
   Projects
   </Menu.Item>
   <Menu.Item name='messages' active={activeItem === 'messages'} onClick={this.handleItemClick}>
   Messages
   </Menu.Item>

   <Dropdown item text='More'>
   <Dropdown.Menu>
   <Dropdown.Item icon='edit' text='Edit Profile' />
   <Dropdown.Item icon='globe' text='Choose Language' />
   <Dropdown.Item icon='settings' text='Account Settings' />
   </Dropdown.Menu>
   </Dropdown>
  </Sidebar>
 )
}
}