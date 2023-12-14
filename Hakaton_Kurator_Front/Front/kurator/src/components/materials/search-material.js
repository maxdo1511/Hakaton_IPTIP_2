"use client"
import "../../css/search-material.css"

const SearchReit = () => {
    return(
        <div>
            <fieldset className={"flex justify-between"}>
                <div className={"flex mb-5"}>
                    <div className={"pr-14 text-4xl mt-7 border-solid border-2 p-2.5"}><span
                        className={"after:content-['▼'] after:ml-0.5 after:text-sky-700"}>Сорт. по рейтингу</span>
                    </div>
                </div>
                <div className={"mb-5 mt-8 site-search-materials"}>
                    <label htmlFor=""></label>
                    <input placeholder={"Начните вводить имя фамилию куратора"} type="search" id="site-search" name="q" className={"border-solid text-3xl border-2 p-1 serch-bar rounded-md mr-2"}/>
                </div>
            </fieldset>
        </div>
    )
}


export default SearchReit