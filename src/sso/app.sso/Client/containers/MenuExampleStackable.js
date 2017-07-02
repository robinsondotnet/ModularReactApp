/**
 * Created by kento on 6/27/17.
 */

import React, { Component } from 'react'
import { Menu, Image, Button} from 'semantic-ui-react'

export default class MenuExampleStackable extends Component {
 state = {}

 handleItemClick = (e, { name }) => this.setState({ activeItem: name })

 render() {
  const { activeItem } = this.state

  return (
  <Menu stackable>
   <Menu.Menu position='right'>
    <Menu.Item>
   <Image src='https://avatars1.githubusercontent.com/u/7469931?v=3&s=40' avatar />
   <span>Kento's Page</span>
   </Menu.Item>
     <Menu.Item>
      <Button primary>
        Send me a message
      </Button>
     </Menu.Item>
   </Menu.Menu>
   </Menu>
 )
}
}
    