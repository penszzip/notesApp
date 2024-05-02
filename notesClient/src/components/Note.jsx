import React from 'react'
import { MdDeleteForever } from 'react-icons/md'

const Note = () => {
  return (
    <div className='note'>
        <span>Lorem ipsum dolor, sit amet consectetur adipisicing elit.</span>
        <div className='note-footer'>
            <small>13/04/2021</small>
            <MdDeleteForever className='delete-icon' size='1.3em' />
        </div>
    
    </div>
  )
}

export default Note