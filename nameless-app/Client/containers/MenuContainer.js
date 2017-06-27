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
  <Sidebar as={Menu} width='thin' icon='labeled' inverted animation='push' visible={true} vertical>
   <Menu.Item>
   <Input placeholder='Search...' />
   </Menu.Item>

   <Menu.Item>
   Home

   <Menu.Menu>
   <Menu.Item name='search' active={activeItem === 'search'} onClick={this.handleItemClick}>
   Search
   </Menu.Item>
   <Menu.Item name='add' active={activeItem === 'add'} onClick={this.handleItemClick}>
   Add
   </Menu.Item>
   <Menu.Item name='about' active={activeItem === 'about'} onClick={this.handleItemClick}>
   Remove
   </Menu.Item>
   </Menu.Menu>
   </Menu.Item>

   <Menu.Item name='browse' active={activeItem === 'browse'} onClick={this.handleItemClick}>
   <Icon name='grid layout' />
   Browse
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