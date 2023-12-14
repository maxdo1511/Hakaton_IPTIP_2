"use client"

import "../../css/rating.css"
import icon from "../../../public/profile-placeholder.svg"
import Image from "next/image";
import {handleImageUpload} from "@/hooks/image_module";


export default function Contacts({user_info}) {
    return(
        <div className={"mt-7 border-solid border-2 border-text-inherit p-2.5 row-span-2"}>
            <h3 className={"text-4xl text-stone-400 mb-10"}>Контакты</h3>
            <div className={" text-2xl mb-12"}>
                <p className={'font-bold mb-7'}>Телефон:</p>
                <p>+7(000)000-00-00</p>
            </div>
            <div className={" text-2xl mb-12"}>
                <p className={'font-bold mb-7'}>Тг:</p>
                <p>@telegram_login</p>
            </div>
            <div className={" text-2xl mb-12"}>
                <p className={'font-bold mb-7'}>email:</p>
                <p>{user_info.user.email}</p>
            </div>
            <div className={" text-2xl mb-12"}>
                <p className={'font-bold'}>резерв:</p>
                <p>example@mail.ru</p>
            </div>
        </div>
    )
}