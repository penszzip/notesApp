import React from 'react'
import { MdDeleteForever } from 'react-icons/md'
import { format, parseISO } from 'date-fns';

const Note = ({ id, text, date, handleDeleteNote }) => {
    return (
        <div className='note'>
            <span>{text}</span>
            <div className='note-footer'>
                <small>{format(parseISO(date), 'MM/dd/yyyy')}</small>
                <MdDeleteForever onClick={() => handleDeleteNote(id)} className='delete-icon' size='1.3em' />
            </div>

        </div>
    )
}

export default Note