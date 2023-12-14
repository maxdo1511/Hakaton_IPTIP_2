"use client"
import "../../css/search.css"
import icon from "../../../public/profile-placeholder.svg"
import Image from "next/image";
import {handleImageUpload} from "@/hooks/image_module";


const Search = () => {
    return(
        <div>
            <fieldset>
                <div className={"flex mb-5"}>
                    <div className={"pr-14 text-4xl mt-7 border-solid border-2 p-2.5"}><span
                        className={"after:content-['▼'] after:ml-0.5 after:text-sky-700"}>Сорт. по рейтингу</span>
                    </div>
                    <div className={"flex ml-2.5"}>
                        <label className={"pl-14 text-4xl mt-7 border-solid border-2 p-2.5 custom-check"}>
                            Куратор-преподаватель
                            <input type="checkbox" className={""}/>
                            <span className="checkmark"></span>
                        </label>
                        <label className={"pl-14 text-4xl mt-7 border-solid border-2 p-2.5 custom-check ml-2.5"}>
                            Куратор-студент
                            <input type="checkbox" className={""}/>
                            <span className="checkmark"></span>
                        </label>
                    </div>
                </div>

                <div className={"mb-5"}>
                    <label htmlFor="site-search"></label>
                    <input placeholder={"Начните вводить имя фамилию куратора"} type="search" id="site-search" name="q" className={"border-solid text-3xl border-2 p-1 serch-bar rounded-md mr-2"}/>
                </div>
            </fieldset>
        </div>
    )
}


export default Search